$file = 'd:\chaves\pass.csv'

if ((Test-Paath -Path $file -PathType Leaf)) {
    $PASS = Import-Csv -Path $file
    $PASS | Format-Table
    Write-Output "ROWS:" $PASS.Length
 }
 else {
  Write-Output "NO FILE"
 }