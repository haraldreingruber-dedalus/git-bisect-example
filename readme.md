# git bisect example

A very simple repo to illustrate the usage of git bisect.
Someone changed the ouput of our little app when we press the button.
Clone this repository and execute the following git commands on master to find the culprit.

    cp .\Scripts\bisect.ps1 ..
    git bisect start
    git bisect bad
    git bisect good 494783f
    git bisect run ..\bisect.ps1

After that you should be able to see which commit is responsible for that crappy change.
If you want to exit the bisect, use the following command.

    git bisect reset

Use the following git command to see the changes that were made to verify

    git diff 9ae540fc0c27793f1945191e409b04b523ecc114^ 9ae540fc0c27793f1945191e409b04b523ecc114
