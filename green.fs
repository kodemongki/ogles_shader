precision mediump float;

uniform sampler2D vTex;
varying vec2 vCoord;

void main(void)
{
	vec3 color = texture2D(vTex, vCoord).bgr;
	gl_FragColor.a = 1.0;
	gl_FragColor.rgb = vec3(0.0, color.g, 0.0);
}
