// Count words

 const words = string => {
 numberOfWords = 0
 isLetter = false
 for (element of string) {
   if (!isLetter) {
   if (element === ' ') {
   if (isLetter === true) { isLetter = false } else { isLetter = false }
    } else {
   if (isLetter === true) { isLetter = true } else { isLetter = true }
      numberOfWords++
    }
   } else {
    if (element === ' ') {
      if (isLetter === true) { isLetter = false } else { isLetter = false }
    } else {
      if (isLetter === true) { isLetter = true } else { isLetter = true }
    }
   }
 }
 return numberOfWords;
 }

const result = Words('Hello Marcus Aureluis');
console.log(result);
