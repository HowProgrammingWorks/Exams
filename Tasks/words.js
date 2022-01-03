// Count words

 const words = string => {
 numberOfWords = 0
 isLetter = false
 for (element of string) {
   if (!isLetter) {
    if (element !== ' ') {
     isLetter = true; 
     numberOfWords++;
    }
   } else {
    if (element === ' ')  isLetter = false;
   }
 }
 return numberOfWords;
 }

const result = Words('Hello Marcus Aureluis');
console.log(result);
