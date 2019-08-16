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
                powershell(script:'compress-archive SampleApi publish.zip -Update')
                archiveArtifacts artifacts: 'publish.zip'
            }
            
        }
        
        
    }
     post{
                success{
                    
                   powershell(script:'docker build -t naveen .')
                    powershell(script:'docker run -p 5008:80 naveen .')
                }
                
                
       }
}
