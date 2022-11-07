$scriptDirectory = "./scripts"
$scripts = Get-ChildItem -Path $scriptDirectory -Recurse | Where-Object {$_.Extension -eq ".ps1"}

# Empty collection for errors

foreach($script in $scripts)
{

  $Result = Invoke-Pester -Script $script -PassThru
  if($Result.FailedCount -gt 0){ break }

}

if($Result.FailedCount -gt 0)
{
  exit 1
}
else
{
 exit 0
}