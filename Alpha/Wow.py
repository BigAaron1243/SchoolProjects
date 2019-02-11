with open('wowow.txt', 'r') as myfile:
    penis = None
    gay = input("Choose operator: ")
    data = "penis = " + myfile.read().replace('\n', gay)
    exec(data)
    print(penis)