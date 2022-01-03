// Validate person name
'use strict'

const isValidate = name => {
  if (typeof name === 'string') {
    for (C of T) {
      if (C === ' ') continue;
      if (C.toLowerCase().charCodeAt(0) >= 97 && C.toLowerCase().charCodeAt(0) <= 122) { } else { return false; }

    return true;
}
}
  else return false;
}

const result = isValidate('Marcus Aurelius');
console.log(result);
