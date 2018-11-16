# GIT BASH WINDOWS
Alias a metre dans le fichier .bash_profile
	
```bash
    echo " ____  ____  ____  ___  _____    ____   __   ____  ____  _  _  _____ "
    echo "(  _ \(_  _)( ___)/ __)(  _  )  (  _ \ /__\ (_  _)(_  _)( \( )(  _  )"
    echo " )(_) )_)(_  )__)( (_-. )(_)(    )___//(__)\  )(   _)(_  )  (  )(_)( "
    echo "(____/(____)(____)\___/(_____)  (__) (__)(__)(__) (____)(_)\_)(_____)"
    
    alias git-clean="git branch | grep -v "master" | xargs git branch -D"
    alias branch="git for-each-ref --sort=committerdate refs/heads/ --format='%(HEAD) %(color:yellow)%(refname:short)%(color:reset) - %(color:red)%(objectname:short)%(color:reset) - %(contents:subject) - %(authorname) (%(color:green)%(committerdate:relative)%(color:reset))'"
    alias grid="git rebase -i develop"
    alias dkps="docker ps -a -q"
    alias back="cd /e/Mobile/mobile-app-backend"
    alias open-back="back && devenv App.sln"
    alias front="cd /Users/dev/Dev/app-v2/ios"
    alias open-front="front && open Photoweb/Photoweb.xcworkspace"
    alias build-back="back && docker-compose -f docker-compose.services.yml -f docker-compose/docker-compose.build.yml build"
    alias start-back="back && docker-compose -f docker-compose.services.yml -f docker-compose/docker-compose.serverbase.yml -f docker-compose/environments/docker-compose.dev.yml up"
    alias rmq="docker run -t --rm -p 15672:15672 -p 5672:5672 repo-docker.factory.groupephotoweb.fr/rabbitmq-dev-photoweb-local-machine"
    alias grih2="git rebase -i HEAD˜2"
    alias gs="git status"
    alias gco="git checkout"
    
    #ORIGINAL GIT
    alias gup="git pull --rebase"
    alias gc="git commit -v"
    alias gc!="git commit -v --amend"
    alias gca="git commit -v -a"
    alias gca!="git commit -v -a --amend"
    alias gcmsg="git commit -m"
    alias gco="git checkout"
    alias gcm="git checkout master"
    alias gr="git remote"
    alias grv="git remote -v"
    alias grmv="git remote rename"
    alias grrm="git remote remove"
    alias gsetr="git remote set-url"
    alias grup="git remote update"
    alias grbi="git rebase -i"
    alias grbc="git rebase --continue"
    alias grba="git rebase --abort"
    alias gb="git branch"
    alias gba="git branch -a"
    alias gcount="git shortlog -sn"
    alias gcl="git config --list"
    alias gcp="git cherry-pick"
    alias glg="git log --stat --max-count=10"
    alias glgg="git log --graph --max-count=10"
    alias glgga="git log --graph --decorate --all"
    alias glo="git log --oneline --decorate --color"
    alias glog="git log --oneline --decorate --color --graph"
    alias gss="git status -s"
    alias ga="git add"
    alias gm="git merge"
    alias grh="git reset HEAD"
    alias grhh="git reset HEAD --hard"
    alias gclean="git reset --hard && git clean -dfx"
    alias gwc="git whatchanged -p --abbrev-commit --pretty=medium"
    alias gsts="git stash show --text"
    alias gsta="git stash"
    alias gstp="git stash pop"
    alias gstd="git stash drop"
    function ggpull {
      git pull origin $(git_current_branch)
    }
    function ggpur {
      git pull --rebase origin $(git_current_branch)
    }
    function ggpush {
      git push origin $(git_current_branch)
    }
    function ggpnp {
      git pull origin $(git_current_branch) && git push origin $(git_current_branch)
    }
    function glp(){
      git log --pretty=$@
    }
    
    ```
