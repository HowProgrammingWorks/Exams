// Validate person name
'use strict';

const validName = (name) => {
  if (typeof name === 'string') {
    const words = name.split(' ');
      for (const word of words) {
      let charCode = word.charCodeAt(0);
      if (charCode < 65 || charCode > 90) return false;
      for (let index = 1; index < word.length; index++) {
        charCode = word.charCodeAt(index);
        if (charCode < 97 || charCode > 122) return false;
      }
    }
    return true;
  }
  else return false;
}

const result = validName('Marcus Aurelius');
console.log(result);
