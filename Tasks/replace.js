'use strict';

// Replace substring with newstr

const replace = (string, subString, newString) => {
  if (subString === '') {
    return string;
  } else {
    let part = string;
    let result = '';
    do {
      const index = part.indexOf(subString);
      if (index === -1) {
        return result + part;
      } else {
        const start = part.substring(0, index);
        part = part.substring(index + subString.length, part.length);
        result += start + newString;
      }
    } while (true);
  }
};

const result = replace('Hello <username> and bye!', '<username>', 'Marcus');
console.log(result);
