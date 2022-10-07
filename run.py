import shutil
import os

os.system("dotnet build")
shutil.move(".\\Wormholes\\bin\\Debug\\Wormholes.dll",
            "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Dyson Sphere Program\\BepInEx\\plugins\\Wormholes.dll")

print("Build successful, and mods moved.")

os.system("\"C:\\Program Files (x86)\\Steam\\steamapps\\common\\Dyson Sphere Program\\DSPGAME.exe\"")