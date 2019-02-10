

def check(word, wordList):
    if word in list:
        print("The word is in the list!")
    else:
        print("The word is not in the list!")


while True:
    userInput = input(">>> ")
    inputLower = userInput.lower()
    inputProcessing = userInput.split(' ')
    print(inputProcessing)
    if inputProcessing in reactionWords:
        print("No you can't say that that's racist")
    else:
        print("I did not understand what you said")
