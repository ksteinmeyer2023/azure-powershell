if(($null -eq $TestName) -or ($TestName -contains 'Get-AzFirmwareAnalysisCryptoKey'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzFirmwareAnalysisCryptoKey.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-AzFirmwareAnalysisCryptoKey' {
    It 'List' {
        { 
            $config = Get-AzFirmwareAnalysisCryptoKey -FirmwareId '7795b9a8-97bb-ba4b-b21a-8dc6ae2dabb9' -ResourceGroupName 'FirmwareAnalysisRG' -WorkspaceName 'default'
            $config.Count | Should -BeGreaterThan 0
        } | Should -Not -Throw
    }
}
