@Library('shared-repo') _

pipeline {
    agent any

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
