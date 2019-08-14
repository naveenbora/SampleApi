
pipeline {    
    agent any
    stages {
        stage('build') {
            steps {
                sh 'dotnet bulid SampleApi.sln -p:configuration release=-v:n'
            }
        }
        stage('test'){
            steps{
                sh 'dotnet test'
            }
        }
    }
}
