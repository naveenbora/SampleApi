pipeline {
    agent any
    parameters{
        string(name:"IMAGENAME")
        
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
        stage('Docker'){
            steps{
                
                powershell(script:'docker build -t naveen .')
                
                
                
                
            }
        }
        
        
    }

}
