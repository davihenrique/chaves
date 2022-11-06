$file = "d:\chaves\pass.csv"

if(Test-Path -Path $file -PathType Leaf)
{
  Remove-Item $file
  Write-Host "DELETED FILE"
}
else
{
  Write-Host "FILE DOES NOT EXIST"
}