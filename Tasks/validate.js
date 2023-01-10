// Validate person name
'use strict';

const isValid = (name) => {
    if (typeof(name) !== 'string' || name.trim() === '' || !name.includes(' ')) {
        return false;
    }
  
    for (let letter of name) {
      if (letter === ' ') continue;
      if ( letter.toLowerCase().charCodeAt(0) < 97 || letter.toLowerCase().charCodeAt(0) > 122) {
          return false;
      }
    }
    
    return true;
};

require('../Tests/validate.js')(isValid);
