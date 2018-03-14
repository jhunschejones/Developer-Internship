# Sorting an Array of Strings

## Objective
Sort an array of words to display the top 5 most frequently occurring words

## Steps Taken
I understand this is likely one of those challenges that could be pieced together with a couple hours on Stack Overflow, but I wanted to challenge myself to come up with some working logic to accomplish the objective using the knowledge I have gained over the past months. I am very aware that there are may ways to solve this challenge and this just represents one, somewhat inefficient yet functional solution.
  
I decided to create an array of my words with a counter variable that would increment each time a word appeared again. From there I bubble-sorted the array from most frequent to least frequent so. Finally, I removed duplicates from the list and displayed the top five results (both in the console log, then on an html page for easier viewing.  

## Outcome
This was quite a fun challenge and I want to thank Sonny, the developer who posed this challenge to me. It really pushed me to think logically though the problem from several angles and brush up on my javascript array skills.

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
