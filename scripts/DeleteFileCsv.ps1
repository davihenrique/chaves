$file = "d:\chaves\pass.csv"

if(Test-Path -Path $file -PathType Leaf)
{
  Remove-Item $file
  Write-Output "DELETED FILE"
}
else
{
  Write-Output "FILE DOES NOT EXIST"
}