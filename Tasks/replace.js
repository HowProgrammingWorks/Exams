// Replace substring with newstr
'use strict';

const Replace = (str, substr, newstr) => {
  if (substr === '') {
    return str;
  } else {
    let res = '';
    for (let i = 0; i < str.length; i++) {
      const index = str.indexOf(substr);
      if (index === -1) {
        break;
      } else {
        const start = str.substring(0, index);
        str = str.substring(index + substr.length, str.length);
        res += start + newstr + str;
        return res;
      }
    }
  }
};

const result = Replace('Hello <username> and bye!', '<username>', 'kekw');
console.log(result);
