'use strict';

const replace = (str, substr, newstr) => {
  if (substr.length === 0) {
    return str;
  } else {
    const index = str.indexOf(substr);
    const start = str.substring(0, index);
    const end = str.substring(index + substr.length, str.length);
    return start + newstr + end;
  }
};

const result = replace('Hello <username> and bye!', '<username>', 'Marcus');
console.log(result);
