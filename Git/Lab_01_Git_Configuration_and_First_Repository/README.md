# Lab 01 - Git Configuration and First Repository

## Objective

- Configure Git on the local machine.
- Configure username and email.
- Set Notepad++ as the default Git editor.
- Initialize a Git repository.
- Add and commit a file.
- Connect a local repository to a remote GitLab repository.
- Push changes to the remote repository.

---

## Prerequisites

- Git Bash installed
- GitLab account
- Notepad++ installed
- Internet connection

---

## Software Used

- Git
- Git Bash
- GitLab
- Notepad++

---

# Step 1: Git Configuration

### Check Git Installation

```bash
git --version
```

Expected Output

```
git version 2.xx.x.windows.x
```

Screenshot:

`screenshots/01_git_version.png`

---

### Configure Username

```bash
git config --global user.name "Your Name"
```

---

### Configure Email

```bash
git config --global user.email "yourmail@example.com"
```

---

### Verify Configuration

```bash
git config --global --list
```

Screenshot:

`02_git_config.png`

---

# Step 2: Configure Notepad++

### Verify Notepad++

```bash
notepad++
```

If not recognized, add the Notepad++ installation path to the Windows Environment Variables.

Screenshot:

`03_notepad_path.png`

---

### Create Alias

Open the Bash profile.

```bash
notepad ~/.bashrc
```

Add

```bash
alias np='notepad++'
```

Save the file and reload.

```bash
source ~/.bashrc
```

---

### Configure Default Editor

```bash
git config --global core.editor "notepad++"
```

Verify

```bash
git var GIT_EDITOR
```

Screenshot:

`04_default_editor.png`

---

# Step 3: Create Local Repository

Create project folder.

```bash
mkdir GitDemo
cd GitDemo
```

Initialize Git.

```bash
git init
```

Screenshot:

`05_git_init.png`

---

### Verify Repository

```bash
ls -la
```

---

### Create File

```bash
echo "Welcome to Git" > welcome.txt
```

---

### Verify File

```bash
ls
```

---

### Display Contents

```bash
cat welcome.txt
```

---

### Check Status

```bash
git status
```

Screenshot:

`06_git_status_before_add.png`

---

### Stage File

```bash
git add welcome.txt
```

Screenshot:

`07_git_add.png`

---

### Commit Changes

```bash
git commit
```

Enter a commit message such as

```
Initial commit

Created welcome.txt
Configured first repository
```

Screenshot:

`08_git_commit.png`

---

### Verify Status

```bash
git status
```

Screenshot:

`09_git_status_after_commit.png`

---

# Step 4: Remote Repository

Create a project named **GitDemo** in GitLab.

Screenshot:

`10_gitlab_repository.png`

Add remote.

```bash
git remote add origin <repository-url>
```

Pull repository.

```bash
git pull origin master
```

Screenshot:

`11_git_pull.png`

Push repository.

```bash
git push origin master
```

Screenshot:

`12_git_push.png`

---

# Output

- Git configured successfully.
- Notepad++ configured as default editor.
- Git repository initialized.
- welcome.txt committed successfully.
- Local repository synchronized with GitLab.

---

# Learning Outcome

After completing this lab, I learned to:

- Install and configure Git.
- Configure username and email.
- Set Notepad++ as the default editor.
- Initialize a local Git repository.
- Stage and commit files.
- Connect a local repository with GitLab.
- Push and pull changes between local and remote repositories.