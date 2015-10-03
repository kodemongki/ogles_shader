precision mediump float;

uniform sampler2D vTex;
varying vec2 vCoord;

const float step_w = 0.0015625;
const float step_h = 0.0027778;

vec3 sharpen(vec3 t1, vec3 t2, vec3 t3, vec3 t4, vec3 t5, vec3 t6, vec3 t7, vec3 t8, vec3 t9)
{
    return -t1 - t2 - t3 - t4 + 9.0 * t5 - t6 - t7 - t8 - t9;
}

void main(void)
{
    vec3 t1 = texture2D(vTex, vec2(vCoord.x - step_w, vCoord.y - step_h)).bgr;
    vec3 t2 = texture2D(vTex, vec2(vCoord.x, vCoord.y - step_h)).bgr;
    vec3 t3 = texture2D(vTex, vec2(vCoord.x + step_w, vCoord.y - step_h)).bgr;
    vec3 t4 = texture2D(vTex, vec2(vCoord.x - step_w, vCoord.y)).bgr;
    vec3 t5 = texture2D(vTex, vCoord).bgr;
    vec3 t6 = texture2D(vTex, vec2(vCoord.x + step_w, vCoord.y)).bgr;
    vec3 t7 = texture2D(vTex, vec2(vCoord.x - step_w, vCoord.y + step_h)).bgr;
    vec3 t8 = texture2D(vTex, vec2(vCoord.x, vCoord.y + step_h)).bgr;
    vec3 t9 = texture2D(vTex, vec2(vCoord.x + step_w, vCoord.y + step_h)).bgr;
   
    vec3 tmp = sharpen(t1, t2, t3, t4, t5, t6, t7, t8, t9);

    gl_FragColor.a = 1.0;
    gl_FragColor.rgb = tmp;
}

