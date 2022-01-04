// Validate person name
'use strict';

const validName = (name) => {
  if (typeof name === 'string') {
    const words = name.split(' ');
      for (let word of words) {
      let charCode = word.charCodeAt(0);
      if (charCode < 65 || charCode > 90) return false;
    }
    return true;
  }
  else return false;
}

const result = validName('Marcus Aurelius');
console.log(result);
