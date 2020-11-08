# 03home-secondGitHubRepo-seliskases
Dieses Projekt dient zur Übung des Workflows von git und GitHub.
Development Platform: Windows, Unity Version: 2020.1.5f1
Target Platform: WebGL  

Lessons learned:
  Verwendete Git commands:
    git clone: Klont das GitHub Repository in die lokale Ordnerstruktur
    git add: Verschiebt einen Folder/eine Datei von der "working Area" in die "staging Area"
    git commit -m "commit message": Speichert die Änderungen der "staging Area" ins lokale(geklonte) Repository
    git push: Synchronisiert die Änderungen, die im lokalen(geklonten) Repository gemacht wurden, mit GitHub
    git pull: Synchronisert die Änderungen, die in GitHub gemacht wurden, mit dem lokalen(geklonten) Repository
  C# Lessons:
    Der Umgang mit UnityEngine.Color, da sich UnityEngine.Color nicht in Color konvertieren lässt.
    Sprich: "Camera.main.backgroundColor = new Color (r, g, b, a);" funktioniert nicht.
