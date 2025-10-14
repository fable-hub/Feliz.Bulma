export async function getSources() {
    const files = import.meta.glob("./../Pages/**/*.fs", { as: "raw"});

    const result = new Map();

    for (const path in files) {
        const mod = await files[path]();
        result.set(path, mod);
    }

    return result;
}
