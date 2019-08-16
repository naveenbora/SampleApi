pipeline {
    agent any
    parameters{
        string(name:"IMAGENAME",defaultValue:"SampleApiImage")
        string(name:"DLLNAME",defaultValue:"SampleApi.dll")
        
    }
    stages {
        stage('Build') {
            steps {
                powershell(script: 'dotnet build ')   
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
   
    }
    post{
        success{
             
             powershell(script:'docker build --build-arg NAME=$DLLNAME -t $IMAGENAME .')
            
        }
    }

}
