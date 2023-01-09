// Validate person name
'use strict';

const isValid = (name) => {
  if (!name) return false;
  if (name === '') return false;
  if (typeof name !== 'string') return false;
  if (name.length === 0) return false;
  if (!name.includes(' ')) return false;
  {
    for (letter of name) {
      if (letter === ' ') continue;
      if (
        letter.toLowerCase().charCodeAt(0) >= 97 &&
        letter.toLowerCase().charCodeAt(0) <= 122
      ) {
      } else {
        return false;
      }
    }
    return true;
  }
};

require('../Tests/validate.js')(isValid);
