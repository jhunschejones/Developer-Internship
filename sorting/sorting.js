var words = ["red", "green", "red", "yellow", "blue", "orange", "purple", "cyan", "magenta", "lime", "pink", "teal", "lavender", "brown", "beige", "red", "maroon", "mint", "olive", "coral", "navy", "grey", "white", "black", "red", "yellow", "blue", "orange", "green", "yellow", "blue", "orange", "purple", "yellow", "blue", "orange", "purple", "cyan", "red"]

// iterate through words list the first time
var counted = []
for (let index = 0; index < words.length; index++) {
    
    var thisWord = words[index];
    var counter = 1;

    // incriment counter if word is already in counted array
    counted.forEach(element => {
        if (element[0] == thisWord) {
            counter++
        }
    });

    counted.push([thisWord, counter]);

    // bubble sort to order by highest counter value
    for (let index = 0; index < counted.length; index++) {
        for (let index2 = 1; index2 < counted.length; index2++) {
            if (counted[index2 - 1][1] < counted[index2][1]) {
                [counted[index2 - 1], counted[index2]] = [counted[index2], counted[index2 - 1]];
            } 
        }
    }    
}

// remove duplicates from list
var countedNoDuplicates = [];
for (let index = 0; index < counted.length; index++) {
    if (countedNoDuplicates.includes(counted[index][0])) {
        // duplicate
    } else {
        countedNoDuplicates.push(counted[index][0]) 
    }  
}

// console log the top 5 most frequent words
for (let index = 0; index < 5; index++) {
    console.log(countedNoDuplicates[index]);
}


// Building a string then displaying on index.html
var topFiveString = ""
for (let index = 0; index < 5; index++) {
    topFiveString = topFiveString + "<li>" + countedNoDuplicates[index] + "</li>"
}
document.getElementById("words").innerHTML = words.join(', ');
document.getElementById("topfive").innerHTML = topFiveString;