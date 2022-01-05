// Convert number to file size in bytes, kb, mb, and gb

const getRoundSize = (size) => {
    if ((size < 0) || (typeof size != 'number'))
        return null;
    else {
        const exp = Math.floor(Math.log(size) / Math.log(1000));
        const PREFIXES = ['b', 'kb', 'mb', 'gb', 'tb', 'pb', 'eb', 'zb', 'yb'];
        return (Math.round(size / (1000 ^ exp)) + ' ' + PREFIXES[exp]);
    }
};

const result = getRoundSize(123456);
console.log(result);
