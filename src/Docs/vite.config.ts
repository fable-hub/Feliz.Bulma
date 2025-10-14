import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'

// vite-echo-file-plugin.ts
import { Plugin } from 'vite';
import path from 'node:path';

function markdownRawPlugin(options: any): Plugin {
    return {
        name: 'vite-raw-plugin',
        transform(code, id) {
            if (options.fileRegex.test(id)) {
                const json = JSON.stringify(code)
                    .replace(/\u2028/g, '\\u2028')
                    .replace(/\u2029/g, '\\u2029')

                return {
                    code: `export default ${json}`
                }
            }
        }
    }
}

export function echoFilePlugin(): Plugin {
    return {
        name: 'vite-echo-file-plugin',
        enforce: 'pre',

        load(id) {
            console.log(id);
            if (!id.endsWith('.raw')) return;

            // // console.log(code)

            // const fileName = path.basename(id); // Get just the file name
            // // Return JS code exporting the filename as default
            // return {
            //     code: `export default ${JSON.stringify(fileName)};`,
            //     map: null, // no source map needed
            // };

            return `\nexport default { render: render }`
        },
    };
}


// https://vitejs.dev/config/
export default defineConfig((env) => {
    const isDevelpoment = env.mode === 'development';

    return {
        css: {
            devSourcemap: isDevelpoment
        },
        plugins: [
            react(),
            // echoFilePlugin()
            markdownRawPlugin({
                fileRegex: /\.fs?raw$/
            })
        ],
        server: {
            watch: {
                ignored: [
                    "**/*.fs"
                ]
            }
        },
        clearScreen: false
    }
})
