using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class EmailTemplateRequest {
    /* Identifier of this email template. */
    public integer id { get; set; }

    /* Displayable name of this email template. */
    public string name { get; set; }

    /* Description of this email template. */
    public string description { get; set; }

    /* Single or multiple receiver addresses. */
    public List<EmailAddress> to { get; set; }

    /* Optional CC receiver addresses. */
    public List<EmailAddress> cc { get; set; }

    /* Optional BCC receiver addresses. */
    public List<EmailAddress> bcc { get; set; }

    /* Text only subject line. */
    public string subject { get; set; }

    /* Text only version of the body. */
    public string body_text { get; set; }

    /* Escaped HTML version of the body. */
    public string body_html { get; set; }

    /* Required sender name and email. */
    public EmailAddress from { get; set; }

    /* Optional reply to name and email. */
    public EmailAddress reply_to { get; set; }

    /* Array of default name value pairs for template replacement. */
    public List<string> defaults { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmailTemplateRequest {\n");
      sb.Append("  id: ").Append(id).Append("\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  description: ").Append(description).Append("\n");
      sb.Append("  to: ").Append(to).Append("\n");
      sb.Append("  cc: ").Append(cc).Append("\n");
      sb.Append("  bcc: ").Append(bcc).Append("\n");
      sb.Append("  subject: ").Append(subject).Append("\n");
      sb.Append("  body_text: ").Append(body_text).Append("\n");
      sb.Append("  body_html: ").Append(body_html).Append("\n");
      sb.Append("  from: ").Append(from).Append("\n");
      sb.Append("  reply_to: ").Append(reply_to).Append("\n");
      sb.Append("  defaults: ").Append(defaults).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
