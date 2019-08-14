
pipeline {
    
    stages {
        stage('build') {
            steps {
                sh 'dotnet bulid SampleApi.sln -p:configuration release=-v:n'
            }
        }
        stage('Test'){
            steps{
                sh 'dotnet test'
            }
        }
    }
}
