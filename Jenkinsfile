Jenkinsfile (Declarative Pipeline)
pipeline {
    agent { docker { image 'dotnet' } }
    stages {
        stage('build') {
            steps {
                sh 'dotnet --version'
            }
        }
    }
}
