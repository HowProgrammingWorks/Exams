'use strict';

// Replace substring with newstr

const replace = (string, subString, newString) => {
  let result;
  if ((subString === '') || (!string.includes(subString))) {
    result = string;
  } else {
    const index = string.indexOf(subString);
    const start = string.substring(0, index);
    const end = string.substring(index + subString.length, string.length);
    result = start + newString + end;
  }
  return result;
};

const result = replace('Hello <username> and bye!', '<username>', 'Marcus');
console.log(result);
