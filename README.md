# gitops-example-app

## Branching Strategy

* dev (default)
* main

## Develop branch
* The code in this branch will be deployed in development environment.
* It can make a pull request only to the main branch.

## Main branch
* This is the main branch, this code is generated a pre release.
* No new branch can be created from main.
* No commits can be directly made in main branch.
* It should accept pull requests only from the develop branch and it should not accept pull requests from other branches.