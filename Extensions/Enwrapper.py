#!/usr/bin/python3
try:
    import time
except:
    print("Error! `time` was not imported correctly.")
start_time = time.time()#Starts program timer

# Py2/3 compatibility from set
# Python3 renamed raw_input to input
#Import modules
try:
    input = raw_input
    pythonv = 2
except NameError:
    pythonv = 3
try:
    import subprocess
except:
    print("Error! `subprocess` was not imported correctly.")
try:
    import time
except:
    print("Error! `time` was not imported correctly.")
try:
    import os
except:
    print("Error! `os` was not imported correctly.")
try:
    import easygui
except:
    print("Error! `easygui` was not imported correctly. Is it installed?")
try:
    import shutil
except:
    print("Error! `shutil` was not imported correctly. Is it installed?")

print("Select path to program(exe, bat etc.)")#Inform user about what to select
filelocation = easygui.fileopenbox()#Ask for path
filename = input("Output name for encoded file[default: encoded.txt]: ")#Ask for filename
if (filename == None) or (filename == ""):#Checks if custom filename was used
    filename = "encoded.txt"#Sets variable
print("Starting encryption...")
print("Input: "+str(filelocation))
print("Output: "+str(filename))
#os.system('certutil -encode "'+str(filelocation)+'" "'+str(filename)+'"')
subprocess.Popen('certutil -encode "'+str(filelocation)+'" "'+str(filename)+'"')
print("Finishing encoded file...")
time.sleep(2)
#Enwrapper starts here
outputfile = str(filelocation).split("\\")#Splits path to find filename
try:
    print(outputfile[-1])#Checks if filelocation list only has 1 object. I now realise that this could be done in a more practical way.
except:
    outputfile = [0] + outputfile
enc = open(str(filename)).read()
f = open(str(filename)+".py", "w")
f.write("#!/usr/bin/python3\n")
f.write("encoded = '''\n")
f.write(str(enc))
f.write("'''")
#f.write('''
#print(encoded)
#open("encodedstring","w").write(encoded)
#try:
#    from subprocess import call
#    call(["certutil", "-decode", "encodedstring", "{0}"])
#    call(["{1}"])
#except:
#    pass
#'''.format(outputfile[-1], outputfile[-1]))
f.write('''
print(encoded)
open("encodedstring","w").write(encoded)
try:
    from subprocess import Popen
    Popen(["certutil", "-decode", "encodedstring", "{0}"])
    Popen(["{1}"])
except:
    pass
'''.format(outputfile[-1], outputfile[-1]))
f.close()
print(enc)
print("Finished wrapping")
time.sleep(1)
print("Starting building")
subprocess.Popen('pyinstaller {0} --onefile'.format(filename+".py"))
time.sleep(20)
print("Finished building")
#os.rename("dist\\"+filename+".py.exe", filename+".py.exe")
def removefile(file):
    try:
        os.remove(file)
    except:
        print("Failed to delete file: {0}".format(file))
def removefolder(folder):
    try:
        shutil.rmtree(folder, ignore_errors=True)
    except:
        print("Failed to delete folder: {0}".format(folder))
print("Done building.\nCleaning temp files")
removefile(filename+".spec")
removefolder("build")
print("Finished deleting temp files")
print("Generating `info.txt` file")
info = open("info.txt", "w")
info.write("Input: "+str(filelocation)+"\nOutput(.py): "+str(filename)+".py\n"+"Output(.exe): dist\\"+str(filename)+".exe\n"+"Raw encoded file: "+str(filename))
info.close()
print("Program finished in")
print("--- %s seconds ---" % (time.time() - start_time))
input("Press ENTER to exit")
