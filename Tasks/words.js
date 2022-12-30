// Count words in a string

let words = s => {
    let amountOfWords = 0;
    let flag = false;
    for (char of s) {
        if (!flag && char !== ' ') {
            flag = true;
            amountOfWords++;
        } else if (char === ' ') {
            flag = false;
        };
    };
    return amountOfWords;
};
  
require('../Tests/words.js')(words);
  
