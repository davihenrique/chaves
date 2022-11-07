$scriptDirectory = "./scripts"
$scripts = Get-ChildItem -Path $scriptDirectory -Recurse | Where-Object {$_.Extension -eq ".ps1"}

# Empty collection for errors

$CODE = 0

foreach($script in $scripts)
{
  $Result = Invoke-Pester -Script $script -PassThru -Quiet
  if($Result.FailedCount -gt 0){ $CODE = 1 }
}
exit $CODE