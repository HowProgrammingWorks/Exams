'use strict';

// Replace substring with newstr

const replace = (string, subString, newString) => {
  let result = '';
  const index = string.indexOf(subString);
  if ((subString === '') || (index === -1)) {
    return string;
  }
  const startIndex = 0;
  const endIndex = index + subString.length;

  const start = string.substring(startIndex, index);
  const end = string.substring(endIndex);
  result += start + newString + end;
  return result;
};

const result = replace('Hello <username> and bye!', '<username>', 'Marcus');
console.log(result);
