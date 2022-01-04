// Validate person name
'use strict'

const isValid = (name) => {
    if (name === '') return false;
    if (typeof (name) !== 'string') return false;
    if (!name.includes(' ')) return false;
    for (const char of name) {
        if (char === ' ') continue;
        if (char.toLowerCase().charCodeAt(0) >= 97 && char.toLowerCase().charCodeAt(0) <= 122) {

        } else return false;
    }
    return true;
}

const result = isValid('Marcus Aurelius');
console.log(result);
