#!/usr/bin/python3
try:
    import time
except:
    print("Error! `time` was not imported correctly.")
start_time = time.time()#Starts program timer

# Py2/3 compatibility from SET
# Python3 renamed raw_input to input
try:
    input = raw_input
    pythonv = 2
except NameError:
    pythonv = 3

#Import modules
try:
    import subprocess
except:
    print("Error! `subprocess` was not imported correctly.")
try:
    import time
except:
    print("Error! `time` was not imported correctly.")
try:
    import os, sys, random
except:
    print("Error! `os` or `sys` was not imported correctly.")
try:
    import shutil
except:
    print("Error! `shutil` was not imported correctly. Is it installed?")

try:
    print(sys.argv[1])
except:
    print("No path selected")
    sys.exit()
filelocation = sys.argv[1]
filename = sys.argv[1].split("\\")[-1]
print("Start encoding...")
print("Input: "+str(filelocation))
print("Output: "+str(filename))
#os.system('certutil -encode "'+str(filelocation)+'" "'+str(filename)+'"')
print('certutil -encode "'+str(filelocation)+'" "'+str(filename)+'"')
subprocess.Popen('certutil -encode "'+str(filelocation)+'" "'+str(filename)+'"')
print("Finishing encoded file...")
time.sleep(2)
#Enwrapper starts here
outputfile = str(filelocation).split("\\")#Splits path to find filename
try:
    print(outputfile[-1])
except:
    outputfile = [0] + outputfile
enc = open(str(filename)).read()
f = open(str(filename)+".py", "w")
f.write("#!/usr/bin/python3\n")
f.write("encoded = '''\n")
f.write(str(enc))
f.write("'''")
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
f.write("#"+str(random.randint(10,10000)))
f.close()
print(enc)
print("Finished wrapping")
time.sleep(1)
print("Starting building")
subprocess.Popen('pyinstaller {0} -F --noconsole'.format(filename+".py"))
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
os.rename("dist\\"+filename, filelocation+".PyWrapped.exe")
removefolder("dist")
print("Finished deleting temp files")
print("Program finished in")
print("--- %s seconds ---" % (time.time() - start_time))
input("Press ENTER to exit")
