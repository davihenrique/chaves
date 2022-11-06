$scriptDirectory = "./scripts"
$scripts = Get-ChildItem -Path $scriptDirectory -Recurse | Where-Object {$_.Extension -eq ".ps1"}
Write-Output $scripts


# Empty collection for errors
$Errors = @()

foreach($script in $scripts)
{

  [void][System.Management.Automation.Language.Parser]::ParseInput($script,[ref]$null,[ref]$Errors)
  if($Errors.Count -gt 0){
    Write-Warning 'Errors found'
  }

}