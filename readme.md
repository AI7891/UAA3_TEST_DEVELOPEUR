# DeskReserve – Client Ticket Analysis

**To:** [Manager / N+1 Name]  
**From:** [Your Name]  
**Date:** [Date]  
**Subject:** Technical analysis and impact assessment – DeskReserve client feedback

---

## Context

Following the email received from the DeskReserve client (Jean-Marc), several issues and feature requests were reported regarding the current application.  
Below is a preliminary technical assessment of the requests, the potential implementation impact, and points requiring clarification.

---

## 1. Multiple reservations for the same desk

### Technical analysis
[Insert explanation of why the issue occurred.]

### Impact of the correction
[Explain what needs to change technically: backend validation, database constraints, API logic, etc.]

---

## 2. Application freeze when cancelling a reservation

### Technical analysis
[Explain the cause of the white screen / freeze.]

### Impact of the correction
[Explain the technical changes required, e.g., frontend state handling, API error handling, React component lifecycle, etc.]

---

## 3. Reservation confirmation email

### Functional request
The client requested that the system automatically send a confirmation email to the user once a reservation has been validated.

### Blocking element / missing information
To implement this feature, the following information is currently missing:

- [Email service or SMTP configuration]
- [Sender email address / domain configuration]
- [Email template or content validation]

### Technical proposal
A possible implementation could involve integrating an email delivery service or library on the backend to automatically trigger a confirmation email after a successful reservation creation.

---

## 4. Request for mobile application publication

### Analysis

The client requested that the application be available on:

- Apple App Store
- Google Play Store

### Technical justification (out of scope)

The current platform is a **web application built with React**.  
Publishing the application on mobile stores would require:

- Developing a **native or hybrid mobile application**
- Adapting the UI and navigation for mobile platforms
- Managing mobile build pipelines and store submission processes

This represents a **separate development project**, which falls outside the scope of the current maintenance and bug-fixing tasks.

---

## Proposed team meeting agenda

To properly address this client ticket, I suggest a short team meeting with the following agenda:

1. Validate the root cause and fix for the double reservation issue
2. Investigate the cancellation bug affecting the frontend
3. Define the architecture for implementing reservation confirmation emails
4. Clarify the scope regarding the mobile application request
5. Prioritize tasks and estimate development time

---

## Conclusion

Please let me know if you would like me to proceed with the proposed corrections or if we should first validate the scope and prioritization with the team.

Best regards,

[Your Name]  
[Your Position]