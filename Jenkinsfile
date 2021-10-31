@Library('shared-repo') _

pipeline {
    stages {
        stage('Test') {
            script {
                echo "Test Stage"
            }
        }
        stage('SharedCode') {
            script {
                integrationTest.run()
            }
        }
    }
}
