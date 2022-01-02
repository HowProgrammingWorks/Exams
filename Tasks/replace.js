'use strict';

// Replace substring with newstr

const replace = (string, subString, newString) => {
  if ((subString === '') || (!string.includes(subString))) {
    return string;
  } else {
    let result = '';
    const index = string.indexOf(subString);
    const part = string.substring(index + subString.length, string.length);
    const start = string.substring(0, index);
    result += start + newString + part;
    return result;
  }
};

const result = replace('Hello <username> and bye!', '<username>', 'Marcus');
console.log(result);
