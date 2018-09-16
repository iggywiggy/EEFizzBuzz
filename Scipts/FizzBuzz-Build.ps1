function buildVS
{
    param
    (
        [parameter(Mandatory=$true)]
        [String] $path,

        [parameter(Mandatory=$false)]
        [bool] $nuget = $true,
        
        [parameter(Mandatory=$false)]
        [bool] $clean = $true,
        
        [parameter(Mandatory=$false)]
        [bool] $test = $true 
    )
    process
    {
        $msBuildExe = 'C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin\msbuild.exe'
        $nugetExe = '.\Tools\nuget.exe'
        $nunitConsole = '.\packages\NUnit.ConsoleRunner.3.9.0\tools\nunit3-console.exe'
        

        if ($nuget) {
            Write-Host "Restoring NuGet packages" -foregroundcolor green
            & "$($nugetExe)" restore "$($path)"
        }

        if ($clean) {
            Write-Host "Cleaning $($path)" -foregroundcolor green
            & "$($msBuildExe)" "$($path)" /t:Clean /m
        }

        Write-Host "Building $($path)" -foregroundcolor green
        & "$($msBuildExe)" "$($path)" /t:Build /m

        if($test) {
            Write-Host "Running Tests $($path)" -foregroundcolor green
            & "$($nunitConsole)" .\EEFizzBuzz.Tests\EEFizzBuzz.Tests.csproj
        }       
    }
}

buildVS .\EEFizzBuzz.sln

