pipeline {
    agent any
    parameters{
        string(name:"IMAGENAME",defaultValue:"SampleApiImage")
        string(name:"SOLUTIONNAME",defaultValue:"SampleApi.sln")
        string(name:"USERNAME",defaultValue:"naveenbora143")
        string(name:"PASSWORD",defaultValue:"8463971887")
        
    }
    stages {
        stage('Build') {
            steps {
                powershell(script: 'dotnet build ${env:SOLUTIONNAME} -p:Configuration=release -v:q')   
            }
        }
        stage('Test'){
          steps  {
                powershell(script:'dotnet test')
          }
       }
       stage('Publish'){
          steps  {
                powershell(script:'dotnet publish')
          }
          
       }
        stage('Archive'){
            steps  {
                
                archiveArtifacts artifacts: 'SampleApi/bin/Debug/netcoreapp2.2/publish/*.*',fingerprint:true
            }
            
        }
        stage('Docker'){
            steps{
                
                powershell(script:'docker build -t ${env:IMAGENAME} .')
                powershell(script:'docker login -u ${env:USERNAME} -p ${env:PASSWORD}')
                
            }
        }
        
        
    }

}
