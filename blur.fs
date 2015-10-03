precision mediump float;
uniform sampler2D vTex;
varying vec2 vCoord;

void main(void)
{
    float step = 0.02;
    vec3 c1 = texture2D(vTex, vec2(vCoord.s - step, vCoord.t - step)).bgr;
    vec3 c2 = texture2D(vTex, vec2(vCoord.s + step, vCoord.t + step)).bgr;
    vec3 c3 = texture2D(vTex, vec2(vCoord.s - step, vCoord.t + step)).bgr;
    vec3 c4 = texture2D(vTex, vec2(vCoord.s + step, vCoord.t - step)).bgr;

    gl_FragColor.a = 1.0;
    gl_FragColor.rgb = (c1 + c2 + c3 + c4) / 4.0;
}
