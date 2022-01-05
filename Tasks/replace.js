// Replace substring with newstr
'use strict';


const replace = (string, subString, newString) => {
  let index = string.indexOf(subString);
  while (index !== -1) {
    const prefix = string.substring(0, index);
    const suffix = string.substring(index + subString.length);
    string = prefix + newString + suffix;
    index = string.indexOf(subString);
  }
  return string;
};

const result = replace('Hello <username> and bye!', '<username>', 'Marcus');
console.log(result);
