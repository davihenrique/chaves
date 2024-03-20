$folderChaves = 'C:\chaves'
$OutFile = "C:\chaves\pass.csv"

if(-not(Test-Path -Path $folderChaves))
{
    mkdir $folderChaves
}

ForEach-Object {
        [PsCustomObject]@{
        Id = "faaa9cf8-fba8-44c5-8fb4-8e02287f8c0f"
        Service = "blogexemplo.com"
        User = "gustavo_bento_barros@comdados.com"
        Pass = "xILcP5fn4J"
    },
        [PsCustomObject]@{
        Id = "a4a39224-c56d-4ab2-a361-5acfd884f2b5"
        Service = "blog2teste.com"
        User = "rayssa-souza77@tce.sp.gov.br"
        Pass = "dUgafo8lol"
    },
        [PsCustomObject]@{
        Id = "1e7ff924-a6bb-4996-984c-54bc4b088208"
        Service = "blog3teste.com"
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
        Service = "EAD2222"
        User = "vicente_victor_silveira@gripoantonin.com"
        Pass = "X1DIeujMej"
    }
} | Export-Csv -Path $Outfile -UseQuotes AsNeeded -NoTypeInformation;

Write-Output "MOCK CREATED `u{2705}"

$file = 'c:\chaves\pass.csv'
if ((Test-Path -Path $file -PathType Leaf))
{
    $PASS = Import-Csv -Path $file
    $PASS | Format-Table
    Write-Output "ROWS:" $PASS.Length
}
else 
{
  Write-Output "NO FILE"
}