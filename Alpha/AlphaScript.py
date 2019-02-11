def check(word, wordList, response):
    if word in wordList:
        print(response)


while True:
    userInput = input("Ask Shit Ai a question: ")
    userInputSplit = userInput.split(" ")
    check(["Nigger", "Nigga"], userInputSplit, "No you cant say that thats racist")
    input()
