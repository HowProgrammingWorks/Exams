'use strict';

const getValueBetween = (str, start, end) => {
    let startIndex = str.indexOf(start);
    if (startIndex === -1) {
        return '';  
    } else {
        startIndex += start.length;
        str = str.substring(startIndex);

        if (end) {
            const endIndex = str.indexOf(end);
            if (endIndex === -1) {
                return '';
            }
            str =  str.substring(0 , endIndex);
        }
    }
    return str;
}

const result = getValueBetween('Hello <username> and bye!', '<', '>');
console.log(result);
