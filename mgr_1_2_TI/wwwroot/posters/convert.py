from PIL import Image
import os

for img in os.listdir():
    try:
        Image.open(img).save(os.path.splitext(img)[0]+'.png')
    except:
        pass

