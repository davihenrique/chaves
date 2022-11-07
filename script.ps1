$scriptDirectory = "./scripts"
$scripts = Get-ChildItem -Path $scriptDirectory -Recurse | Where-Object {$_.Extension -eq ".ps1"}
$CODE = 0
foreach($script in $scripts)
{
  $Result = Invoke-Pester -Script $script -PassThru
  if($Result.FailedCount -gt 0)
  {
     $CODE = 1 
  }
}
if($CODE.Equals(1))
{
  Write-Error "DEU RUIM" -ErrorAction Stop
}
else
{
  Write-Output "DEU BOM"
}