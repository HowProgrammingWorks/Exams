// Validate person name
'use strict';

const validName = (name) => {
  const keyCodes = {A: 65, Z: 90, a: 97, z: 122}
  if (typeof name === 'string') {
    const words = name.split(' ');
      for (const word of words) {
      let charCode = word.charCodeAt(0);
      if (charCode < keyCodes.A || charCode > keyCodes.Z) return false;
      for (let index = 1; index < word.length; index++) {
        charCode = word.charCodeAt(index);
        if (charCode < keyCodes.a || charCode > keyCodes.z) return false;
      }
    }
    return true;
  }
  else return false;
}

const result = validName('Marcus Aurelius');
console.log(result);
