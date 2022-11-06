$folderChaves = 'd:\chaves'
$OutFile = "d:\chaves\pass.csv"

if(-not(Test-Path -Path $folderChaves))
{
    mkdir $folderChaves
}

ForEach-Object {
        [PsCustomObject]@{
        Id = "faaa9cf8-fba8-44c5-8fb4-8e02287f8c0f"
        Service = "tumblr.com"
        User = "gustavo_bento_barros@comdados.com"
        Pass = "xILcP5fn4J"
    },
        [PsCustomObject]@{
        Id = "a4a39224-c56d-4ab2-a361-5acfd884f2b5"
        Service = "twitter.com"
        User = "rayssa-souza77@tce.sp.gov.br"
        Pass = "dUgafo8lol"
    },
        [PsCustomObject]@{
        Id = "1e7ff924-a6bb-4996-984c-54bc4b088208"
        Service = "orkut.com"
        User = "manuela_giovana_porto@veraparodi.com.br"
        Pass = "TipRc49PKy"
    },
        [PsCustomObject]@{
        Id = "1e7ff924-a6bb-4996-984c-54bc4b088210"
        Service = "firefox.com"
        User = "lais_sophie_viana@dinamicaconsultoria.com"
        Pass = "tD0qX%0DHQ9w2PMj2hMv"
    },
        [PsCustomObject]@{
        Id = "7c50c866-7aa4-43f2-90e2-ad1b6c6f0e94"
        Service = "EAD"
        User = "vicente_victor_silveira@gripoantonin.com"
        Pass = "X1DIeujMej"
    }

} | Export-Csv -Path $Outfile -UseQuotes AsNeeded -NoTypeInformation;

Write-Host "MOCK CREATED `u{2705}"

if ((Test-Path -Path $OutFile -PathType Leaf)) {
    $PASS = Import-Csv -Path $OutFile
    $PASS | Format-Table
    Write-Host "ROWS:" $PASS.Length
 }
 else {
    Write-Host "NO FILE"
 }
