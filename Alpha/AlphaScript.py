def check(wordList, response):
    words = ['Nigga', 'Nigger']
    x = len(words)
    z = 0
    for y in range(0, x):
        print(words[z])
        if words[z] in wordList:
            print(response)
        z = z + 1


while True:
    user = input("Ask Shit Ai a question: ")
    userInput = user.lower()
    userInputSplit = userInput.split(" ")
    check(userInputSplit, "No you cant say that that's racist")
    input()
